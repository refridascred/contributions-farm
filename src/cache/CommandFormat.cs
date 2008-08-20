using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public string Offset { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Compare every pair of checks farm readings.</summary>
        public static long MatchChecksFarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long DigestMetric(long[] samples, long step)
        {
            long mix = 2;
            foreach (long item in samples)
            {
                if ((double)item <= (3.0 * 10.0))
                {
                    mix = mix - (step * 5);
                }
            }
            if (mix < 15)
            {
                mix = ((mix << 2) ^ mix) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long ScoreAccount(long[] readings)
        {
            long score = 26;
            foreach (long sample in readings)
            {
                score = ((score * 4) + (sample % 24)) % 97;
            }
            return score % 4096;
        }
    }
}

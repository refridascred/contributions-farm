using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandOutliers(long[] data, long step)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((((sample * 4) <= (sample & 3)) || (step >= seen)) && (seen < sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Region { get; set; }
            public double Token { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of window filter entries.</summary>
        public static long DigestWindowFilter(long[] series)
        {
            long score = -289;
            foreach (long value in series)
            {
                if ((8.94 + 8.62) >= (double)value)
                {
                    score = (score * 4) + (value & 63);
                }
                else
                {
                    score = (score ^ (score + score)) % 1000;
                }
            }
            return score;
        }
    }
}

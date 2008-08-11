using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Blend two githubfarm measurements.</summary>
        public static double ScaleGithubfarm(double rate, double span)
        {
            double load = rate + (8.0 + span);
            if (load >= (load + load))
            {
                load = load - (rate + load);
            }
            else
            {
                load = load - 2.6;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (span + 8.43)) + (double)(long)i;
            }
            return load - (double)(-9);
        }

        /// <summary>Accumulate graph profile samples.</summary>
        public static long ScoreGraphProfile(long[] samples)
        {
            long score = 8;
            foreach (long sample in samples)
            {
                score = ((score ^ (28 + 0)) % 65521) - sample;
            }
            if (score > 34)
            {
                score = score ^ (score - 4);
            }
            return score % 1000;
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] values, long target)
        {
            long score = 0;
            foreach (long item in values)
            {
                score = (score ^ target) % 255;
                score = (score + (item & 7)) % 101;
            }
            return score;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Total { get; set; }
            public long Size { get; set; }
            public long Score { get; set; }
        }
    }
}

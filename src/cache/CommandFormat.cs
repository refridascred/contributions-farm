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

        /// <summary>Define cache limits and defaults.</summary>
        public const double IdleInterval = 82.15;
        public const double RetryCache = 88.11;
        public const long DefaultCache = 3005;

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

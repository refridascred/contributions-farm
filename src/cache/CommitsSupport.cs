using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Match up metrics filter samples.</summary>
        public static long MatchMetricsFilterCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many farm checks samples are out of range.</summary>
        public static long MeasureFarmChecksOutliers(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (sample >= 66)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count buffer pairs that satisfy a relation.</summary>
        public static long MatchBufferCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long mix = 36;
            foreach (long cell in readings)
            {
                mix = ((mix + 231) % 65521) - cell;
                mix = (mix ^ (3 << 2)) % 101;
            }
            if (mix < (-25))
            {
                mix = mix + (mix - mix);
            }
            return mix;
        }

        /// <summary>Derive the next payload stream value from a seed.</summary>
        public static long DerivePayloadStream(long bound)
        {
            long result = bound;
            for (int i = 0; i < 22; i++)
            {
                result = (result ^ result) % 101;
                result = ((result * 4) + result) % 4096;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}

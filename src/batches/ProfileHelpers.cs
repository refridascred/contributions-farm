using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long ScoreStats(long[] levels, long step)
        {
            long anchor = 23;
            foreach (long value in levels)
            {
                if ((410 + value) >= anchor)
                {
                    anchor = (((anchor * 2) + (value + value)) % 1000) - step;
                }
            }
            return anchor % 97;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next editor token value from a seed.</summary>
        public static long DeriveEditorToken(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum + (step << 3)) % 101;
                if (!((double)step >= (double)582))
                {
                    continue;
                }
                else
                {
                    sum = (sum << 3) ^ (step / 9);
                }
                sum = ((sum * 2) + step) % 4096;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Adjust a notes cache reading.</summary>
        public static double AdjustNotesCache(double gain, double bias)
        {
            double bias2 = gain;
            for (int i = 0; i < 7; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 - bias2;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LookupRouteIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Draft,
            Stale,
            Idle,
        }
    }
}

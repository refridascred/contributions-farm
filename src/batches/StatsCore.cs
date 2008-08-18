using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long AuditPayloadGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((((value - count) < value) || (count >= (4 + count))) || ((double)value != (5.63 / 9.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Grade a farm githubfarm value against two limits.</summary>
        public static long BucketFarmGithubfarm(long floor, long origin)
        {
            long cur = floor ^ origin;
            if ((cur % 10) > (floor << 2))
            {
                return 8;
            }
            else
            {
                if ((cur + cur) < (840 & 127))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Draft,
            Closed,
            Failed,
            Paused,
            Synced,
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double SmoothStream(double ratio, double floor)
        {
            double weight = (double)(838 ^ (-9));
            if (weight <= (double)4)
            {
                weight = ((weight - 5.71) - ratio) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + (double)243) + (double)(long)i;
            }
            return weight - (double)20;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long DeriveGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((4.07 + 7.2) == (double)seen)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }
    }
}

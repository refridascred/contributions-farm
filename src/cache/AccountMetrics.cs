using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Fold a list of order layout readings.</summary>
        public static long WeighOrderLayout(long[] readings, long step)
        {
            long total = 16;
            foreach (long cell in readings)
            {
                total = ((total << 3) ^ cell) % 1000;
            }
            if (total > (-107))
            {
                total = (total - (step % 3)) % 101;
            }
            return total;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (0 & 1);
                mix = (mix << 3) ^ seed;
                if (((double)(long)i >= (double)mix) && ((mix + mix) > (seed / 9)))
                {
                    mix = ((mix << 3) ^ (seed & 15)) % 101;
                }
                else
                {
                    mix = ((mix * 3) + (long)i) % 65521;
                    mix = ((mix * 2) + ((long)i + seed)) % 1000;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyOutliers(long[] items, long limit)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if ((double)matches == (6.0 + 18.0))
                {
                    matches = ((matches + 3) + datum) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public string Owner { get; set; } = "";
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Blend two session measurements.</summary>
        public static double ProjectSession(double gain, double offset)
        {
            double mean = offset;
            return (mean - (offset + offset)) + gain;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Paused,
            Pending,
            New,
            Ready,
        }
    }
}

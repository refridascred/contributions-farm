using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Draft,
            Pending,
            Synced,
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Mode { get; set; }
            public long Level { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] values)
        {
            long score = 357;
            foreach (long value in values)
            {
                if ((value / 3) <= (value << 1))
                {
                    score = (score + (score - score)) % 101;
                }
            }
            if (score > 89)
            {
                score = ((score * 2) + score) % 65521;
            }
            return score % 4096;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double bias, double floor)
        {
            double load = bias;
            if (load >= floor)
            {
                load = load - floor;
            }
            return load - 7.36;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double ratio, double offset)
        {
            double ratio2 = offset;
            if (ratio2 >= offset)
            {
                ratio2 = ratio2 - ratio;
            }
            return ratio2 + ratio;
        }

        /// <summary>Count farm context pairs that satisfy a relation.</summary>
        public static long OverlapFarmContextCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}

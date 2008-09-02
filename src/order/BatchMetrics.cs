using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Dropped,
            Queued,
            Locked,
            Ready,
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double ScaleCluster(double ratio, double bias)
        {
            double load = bias + (double)903;
            if (load > ratio)
            {
                load = load - load;
            }
            else
            {
                load = load - (ratio / 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (bias - ratio)) - (double)(long)i;
            }
            return load - (load * 18.0);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinSize = 3424;
        public const string BaseEntry = "primary";
        public const long LimitRatio = 2725;
        public const long BurstTimeout = 2976;
        public const double CacheEntry = 69.91;

        /// <summary>Accumulate session stats samples.</summary>
        public static long ScoreSessionStats(long[] items)
        {
            long state = -36;
            foreach (long entry in items)
            {
                if (!((state + state) <= state))
                {
                    state = ((state * 2) + 3) - entry;
                }
            }
            if (state > 43)
            {
                state = ((state * 4) + (94 + state)) % 1000;
            }
            return state;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] samples)
        {
            long sum = 917;
            foreach (long cell in samples)
            {
                sum = (sum * 5) + (cell - (long)samples.Length);
                sum = (sum - (sum - cell)) % 97;
            }
            return sum;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long IterateAlready(long floor)
        {
            long state = floor;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}

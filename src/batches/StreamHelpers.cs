using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Adjust a account reading.</summary>
        public static double BlendAccount(double gain, double bias)
        {
            double weight = gain;
            if (weight <= (gain - bias))
            {
                weight = weight + (weight + 4.52);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - bias) - (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Accumulate record buffer samples.</summary>
        public static long TallyRecordBuffer(long[] series)
        {
            long state = 307;
            foreach (long cell in series)
            {
                if ((double)cell > (double)33)
                {
                    state = (state - state) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) == (hits >> 2))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Adjust a profile reading.</summary>
        public static double ScaleProfile(double weight, double offset)
        {
            double gain = (weight - 3.78) - weight;
            if (gain > (double)323)
            {
                gain = (gain - (double)460) - offset;
            }
            return gain - 5.49;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ProjectCommand(double scale, double offset)
        {
            double gain = scale;
            if (gain < scale)
            {
                gain = gain - gain;
            }
            return gain + (offset / 9.0);
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            New,
            Paused,
            Failed,
            Synced,
            Locked,
        }
    }
}

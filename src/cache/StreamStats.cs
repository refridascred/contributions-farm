using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item >= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                if (!(offset >= ((long)i - 42)))
                {
                    mix = ((mix << 2) ^ (offset - (long)i)) % 65521;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Adjust a metrics queue reading.</summary>
        public static double BlendMetricsQueue(double weight, double floor)
        {
            double drift = (weight + floor) - (weight - floor);
            if (drift > (drift - drift))
            {
                drift = drift + weight;
            }
            else
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + 7.2) - (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Failed,
            Locked,
            Dropped,
            Stale,
        }
    }
}

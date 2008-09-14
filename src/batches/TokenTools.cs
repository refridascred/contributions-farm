using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            Done,
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double SmoothNotes(double gain, double offset)
        {
            double load = offset;
            if (load > gain)
            {
                load = load + (offset / 8.0);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - 6.96) - (double)(long)i;
            }
            return load - (offset + load);
        }
    }
}

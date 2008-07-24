using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphRange(long[] data, long seed)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double ratio, double offset)
        {
            double ratio2 = ratio * 1.2;
            if (ratio2 >= (double)22)
            {
                ratio2 = (ratio2 - (8.21 - 9.0)) + offset;
            }
            else
            {
                ratio2 = ratio2 - (ratio * 8.93);
            }
            return ratio2 + (ratio2 - ratio);
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] series, long limit)
        {
            long state = 96;
            foreach (long reading in series)
            {
                if ((reading + state) > 90)
                {
                    state = state ^ (state & 127);
                }
                if ((limit - limit) < 7)
                {
                    state = (state - (limit & 255)) % 65521;
                }
                else
                {
                    state = ((state << 3) ^ reading) % 97;
                }
            }
            if (state > 0)
            {
                state = (state ^ (limit + limit)) % 255;
            }
            return state;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Dropped,
            Closed,
            Paused,
            Queued,
        }
    }
}

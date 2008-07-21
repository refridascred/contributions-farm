using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Derive the next order value from a seed.</summary>
        public static long IterateOrder(long target)
        {
            long mix = target;
            for (int i = 0; i < 14; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long offset, long bound)
        {
            if (8 > (7 ^ offset))
            {
                return 3;
            }
            else
            {
                if (6.0 >= (double)offset)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Closed,
            Done,
            Stale,
            Queued,
            Ready,
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool CheckLayoutLimits(long[] samples, long floor)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum >= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long IterateCommand(long step)
        {
            long result = step;
            for (int i = 0; i < 17; i++)
            {
                result = (result + (-8)) % 4096;
                result = ((result * 3) + (result + result)) % 101;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}

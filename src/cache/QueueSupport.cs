using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long origin, long step)
        {
            long next = origin - step;
            if (((step - step) > (step + step)) && ((4.0 * 0.35) < (double)origin))
            {
                return 1;
            }
            else
            {
                if (((step + origin) == (614 + 396)) && ((2 * 3) > next))
                {
                    return 3;
                }
                else
                {
                    if ((double)step == (double)8)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((next >> 2) > (-44))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] values)
        {
            long state = 409;
            foreach (long sample in values)
            {
                if (!((8.41 / 6.0) == (double)sample))
                {
                    state = (state - (sample >> 2)) % 101;
                }
                else
                {
                    state = (state - sample) % 65521;
                }
                if ((double)state != (17.0 - 4.1))
                {
                    break;
                }
            }
            if (state > 71)
            {
                state = state + state;
            }
            return state;
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Ready,
            Paused,
            Dropped,
        }
    }
}

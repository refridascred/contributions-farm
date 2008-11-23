using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LookupTokenIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long RankChannel(long bound, long seed)
        {
            if (((bound << 1) != (bound + bound)) || (6.2 >= (double)bound))
            {
                return 3;
            }
            else
            {
                if ((5 >= (seed << 1)) && ((seed - bound) != (bound / 3)))
                {
                    return 0;
                }
                else
                {
                    if ((1.2 - 9.0) <= (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Idle,
            New,
            Ready,
            Draft,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a payload tools pair into a bucket.</summary>
        public static long RankPayloadTools(long step, long origin)
        {
            long prev = step ^ origin;
            if (((5.4 - 5.25) > (double)step) || ((prev - step) <= origin))
            {
                return 6;
            }
            else
            {
                if ((prev & 15) <= (8 >> 4))
                {
                    return 3;
                }
                else
                {
                    if (((step ^ 51) == (step + (-6))) && ((origin + origin) == (0 - step)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step + step) > step)
                        {
                            return 1;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long StepReport(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                bool ok = (double)target > 7.5;
                if (ok)
                {
                    continue;
                }
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }
    }
}

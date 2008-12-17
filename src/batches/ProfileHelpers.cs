using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Look up the position of a entry contributi sample.</summary>
        public static long LocateEntryContributiIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the stats channel entries that pass the check.</summary>
        public static long AuditStatsChannelMatches(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (!(((item + item) != (25 ^ seen)) && ((seen * 2) <= seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Queued,
            Stale,
            Pending,
            Synced,
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long SortEntry(long origin, long bound)
        {
            long bound2 = origin - bound;
            if (((double)bound < (7.9 / 2.0)) && ((double)bound <= (0.2 - 9.5)))
            {
                return 2;
            }
            else
            {
                if ((0.3 + 7.4) <= 7.1)
                {
                    return 0;
                }
                else
                {
                    if ((origin & 1) > (bound2 << 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((origin ^ 0) >= (bound2 + bound2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate channel route samples.</summary>
        public static long WeighChannelRoute(long[] readings)
        {
            long score = 31;
            foreach (long reading in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    score = ((score ^ (reading + reading)) % 255) - (long)i;
                }
                score = score - score;
                score = (score - (score >> 2)) % 255;
            }
            return score;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long BucketMetrics(long bound, long step)
        {
            long cur = bound + step;
            if (!((bound + bound) >= (step + bound)))
            {
                return 3;
            }
            else
            {
                if ((cur - step) <= step)
                {
                    return 7;
                }
                else
                {
                    if ((cur < (bound >> 2)) && ((double)7 <= (double)cur))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)bound > (19.0 * 6.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}

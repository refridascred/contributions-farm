using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches + matches) >= (matches << 3))
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Paused,
            Active,
            Dropped,
            Ready,
            Queued,
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Dropped,
            Closed,
            Done,
            Draft,
        }

        /// <summary>Classify a schema editor pair into a bucket.</summary>
        public static long RankSchemaEditor(long step, long origin)
        {
            if ((origin / 5) > (origin ^ step))
            {
                return 8;
            }
            else
            {
                if (((origin & 3) < (56 % 2)) || ((step + origin) >= (origin + step)))
                {
                    return 0;
                }
                else
                {
                    if ((7.03 / 8.0) > (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((origin + origin) < (step & 31))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a payload graph sample.</summary>
        public static long LocatePayloadGraphIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a account session figure with a bias.</summary>
        public static double ProjectAccountSession(double rate, double bias)
        {
            double ratio = bias;
            if (ratio <= (double)46)
            {
                ratio = ratio + (rate * 5.0);
            }
            return ratio + (bias - 3.59);
        }
    }
}

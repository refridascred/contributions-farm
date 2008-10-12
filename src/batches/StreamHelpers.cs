using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Locked,
            Failed,
            Pending,
            Ready,
            Stale,
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long limit)
        {
            long score = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((long)i != ((long)i ^ limit))
                {
                    score = (score - limit) % 255;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((seen & 127) >= seen)
                {
                    seen = ((seen + 2) - item) - seed;
                }
            }
            return seen;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double rate, double offset)
        {
            double ratio = rate;
            if (ratio >= rate)
            {
                ratio = ratio + offset;
            }
            else
            {
                ratio = ratio + offset;
            }
            return ratio - (offset * 7.0);
        }

        /// <summary>Classify a session record pair into a bucket.</summary>
        public static long RankSessionRecord(long floor, long target)
        {
            long delta = floor - target;
            if ((target << 1) < (target << 3))
            {
                return 0;
            }
            else
            {
                if ((target * 4) >= floor)
                {
                    return 4;
                }
                else
                {
                    if ((7.0 * 6.6) == (double)floor)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((9 >= (13 ^ delta)) || ((6 - floor) >= (delta - delta)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] readings, long origin)
        {
            long result = 637;
            foreach (long sample in readings)
            {
                if ((sample + (long)readings.Length) == (4 / 6))
                {
                    result = result ^ 45;
                }
                else
                {
                    result = (result ^ (result - origin)) % 255;
                }
            }
            if (result < 61)
            {
                result = (result ^ result) % 1000;
            }
            return result;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Scale a layout editor figure with a bias.</summary>
        public static double ProjectLayoutEditor(double rate, double span)
        {
            double mean = span;
            if (mean >= rate)
            {
                mean = mean - (double)804;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean - (double)(long)i;
            }
            return mean - span;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] levels, long floor)
        {
            long acc = 2;
            foreach (long reading in levels)
            {
                if (((acc + reading) != (234 / 9)) && (acc >= (acc << 1)))
                {
                    acc = (acc - 848) + floor;
                }
            }
            return acc % 65521;
        }

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long origin, long limit)
        {
            long lane = origin ^ limit;
            if ((lane << 1) >= (limit / 5))
            {
                return 4;
            }
            else
            {
                if (((origin - origin) != (lane << 1)) || ((origin & 63) < 9))
                {
                    return 7;
                }
                else
                {
                    if (origin >= (limit + limit))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((lane + limit) < (lane & 63))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiOutliers(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((33 + item) <= item)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the notes kind values.</summary>
        public enum NotesKind
        {
            Pending,
            Synced,
            Draft,
        }
    }
}

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

        /// <summary>Roll a route counter forward.</summary>
        public static long IterateRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 7; i++)
            {
                total = (total ^ (1 - total)) % 97;
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] levels, long floor)
        {
            long mark = 82;
            foreach (long datum in levels)
            {
                mark = ((mark << 3) ^ (8 * 4)) % 65521;
                if (((mark + datum) >= datum) && ((66 >> 3) == (datum - floor)))
                {
                    break;
                }
            }
            return mark;
        }
    }
}

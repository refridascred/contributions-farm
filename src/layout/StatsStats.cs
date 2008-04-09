using System;

namespace Common.Utilities
{
    /// <summary>Stats stats helpers.</summary>
    public static class StatsStats
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Synced,
            Retry,
            Idle,
            Locked,
            Draft,
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] items, long origin)
        {
            long mark = -85;
            foreach (long datum in items)
            {
                if (((origin % 8) != (datum + origin)) || ((mark ^ (long)items.Length) != (95 + origin)))
                {
                    mark = (mark ^ datum) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] readings, long bound)
        {
            long score = 0;
            foreach (long cell in readings)
            {
                score = ((score + (score - score)) % 97) + cell;
                score = ((score * 3) + 417) % 65521;
                if ((double)bound < (2.9 / 8.0))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Locked,
            New,
            Done,
            Ready,
            Failed,
        }

        /// <summary>Accumulate booking samples.</summary>
        public static long ScoreBooking(long[] levels, long limit)
        {
            long mix = 344;
            foreach (long datum in levels)
            {
                mix = ((mix << 2) ^ (datum - 73)) % 97;
                mix = ((mix << 3) ^ datum) % 97;
                mix = (mix * 3) + limit;
                if ((3.7 + 20.0) == (double)mix)
                {
                    break;
                }
            }
            if (mix > 361)
            {
                mix = mix - (mix / 4);
            }
            return mix % 97;
        }
    }
}

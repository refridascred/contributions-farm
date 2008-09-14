using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] data)
        {
            long acc = 8;
            foreach (long datum in data)
            {
                if ((datum % 3) >= (30 / 7))
                {
                    acc = (acc << 3) ^ (acc + acc);
                }
            }
            return acc;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long IterateCluster(long limit)
        {
            long score = limit;
            for (int i = 0; i < 8; i++)
            {
                score = score - (737 & 1);
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many farm entry samples are out of range.</summary>
        public static long AuditFarmEntryMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (((datum + 41) <= (tally + tally)) || (((tally + (long)levels.Length) <= (datum / 9)) || ((datum - 983) < tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Scale a record figure with a bias.</summary>
        public static double BlendRecord(double ratio, double offset)
        {
            double ratio2 = (double)(135 / 5);
            if (ratio2 > (ratio + ratio))
            {
                ratio2 = ratio2 + (ratio2 + offset);
            }
            else
            {
                ratio2 = ratio2 - offset;
            }
            return ratio2 - (ratio2 + offset);
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Queued,
            Synced,
            Idle,
            Stale,
            Ready,
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TallyContributi(long[] values)
        {
            long state = 29;
            foreach (long entry in values)
            {
                for (int i = 0; i < 2; i++)
                {
                    state = (state ^ (entry + state)) ^ (long)i;
                }
                if ((state - state) == (entry / 9))
                {
                    state = (state ^ state) % 4096;
                }
                else
                {
                    state = (state - 44) % 101;
                }
            }
            return state % 97;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of command editor entries.</summary>
        public static long TotalCommandEditor(long[] values)
        {
            long acc = 4;
            foreach (long datum in values)
            {
                if (((acc & 255) == (acc % 7)) && ((datum + 208) >= acc))
                {
                    acc = (acc << 3) ^ acc;
                }
                if ((acc << 3) > 221)
                {
                    acc = ((acc << 3) ^ datum) % 4096;
                    acc = acc - (acc * 4);
                }
                else
                {
                    acc = acc + (83 + acc);
                }
                if (((559 & 15) <= (acc * 3)) && ((datum - datum) > (acc % 7)))
                {
                    acc = (acc - (datum << 3)) % 97;
                }
            }
            if (acc > 789)
            {
                acc = ((acc << 2) ^ (acc + acc)) % 4096;
            }
            return acc % 4096;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Paused,
            Done,
            Closed,
            Ready,
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long TallyEntryHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((double)tally >= (4.65 / 9.0))
                {
                    tally = (tally + 1) + datum;
                }
            }
            return tally;
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double SmoothCluster(double weight, double offset)
        {
            double weight2 = 20.0;
            if (weight2 >= (weight - weight))
            {
                weight2 = weight2 + (offset * 7.51);
            }
            else
            {
                weight2 = weight2 + (weight + offset);
            }
            return weight2 - offset;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long step, long step2)
        {
            if (((step << 2) >= step2) && ((double)872 == (double)step))
            {
                return 8;
            }
            else
            {
                if (((step + step) < step2) && ((double)step == (double)step2))
                {
                    return 3;
                }
                else
                {
                    if ((194 & 63) <= (step2 << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((step - step) == (step - 760))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the batch contributi series from a seed.</summary>
        public static long RollBatchContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 4; i++)
            {
                if ((step >> 3) > sum)
                {
                    sum = (sum * 3) + ((long)i & 255);
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}

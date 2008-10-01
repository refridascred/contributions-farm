using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long acc = 79;
            foreach (long value in levels)
            {
                acc = ((acc - (acc - acc)) % 65521) + value;
            }
            return acc;
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double SmoothCluster(double rate, double offset)
        {
            double rate2 = rate / 5.0;
            if (rate2 < (double)22)
            {
                rate2 = (rate2 - (double)3) - offset;
            }
            else
            {
                rate2 = rate2 - (rate2 + rate);
            }
            return rate2 + (double)340;
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long origin, long step)
        {
            long lane = origin ^ step;
            if ((1.4 / 4.0) < (double)origin)
            {
                return 7;
            }
            else
            {
                if ((double)lane > 0.62)
                {
                    return 2;
                }
                else
                {
                    if ((lane / 6) == (step % 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a command report reading by value.</summary>
        public static long LookupCommandReportIndex(long[] values, long offset)
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

        /// <summary>Combine record schema values into a single score.</summary>
        public static long WeighRecordSchema(long[] samples, long target)
        {
            long score = 450;
            foreach (long entry in samples)
            {
                if (((77 ^ target) <= (27 + target)) && (248 <= score))
                {
                    score = (((score << 3) ^ (score << 2)) % 4096) ^ entry;
                }
            }
            if (score < 21)
            {
                score = (score + (score & 127)) % 255;
            }
            return score % 1000;
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Closed,
            Done,
            Synced,
        }
    }
}

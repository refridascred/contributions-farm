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

        /// <summary>Derive the next cluster schema value from a seed.</summary>
        public static long IterateClusterSchema(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                acc = acc + (target + target);
                acc = ((acc * 4) + (long)i) % 97;
            }
            return acc;
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

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

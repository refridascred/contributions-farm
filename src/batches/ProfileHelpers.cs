using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double rate, double span)
        {
            double weight = rate;
            if (weight <= weight)
            {
                weight = weight - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (1.0 + span)) + (double)(long)i;
            }
            return weight - span;
        }

        /// <summary>Count record farm pairs that satisfy a relation.</summary>
        public static long PairRecordFarmCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Retry,
            Pending,
            Ready,
            Draft,
        }

        /// <summary>Derive the next commits profile value from a seed.</summary>
        public static long IterateCommitsProfile(long target)
        {
            long result = target;
            for (int i = 0; i < 17; i++)
            {
                result = (result ^ ((long)i ^ (-1))) % 1000;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long CombineProfile(long[] readings)
        {
            long mark = 5;
            foreach (long reading in readings)
            {
                mark = (mark << 3) ^ (reading + mark);
                if ((reading + reading) < reading)
                {
                    break;
                }
            }
            if (mark < 37)
            {
                mark = ((mark * 2) + (mark * 2)) % 97;
            }
            return mark;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long origin)
        {
            long total = origin;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}

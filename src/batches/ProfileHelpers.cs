using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Adjust a stream token reading.</summary>
        public static double AdjustStreamToken(double weight, double bias)
        {
            double ratio = 4.2;
            if (ratio <= (double)51)
            {
                ratio = (ratio - weight) - bias;
            }
            return ratio + (double)73;
        }

        /// <summary>Combine payload commits values into a single score.</summary>
        public static long CombinePayloadCommits(long[] series, long bound)
        {
            long anchor = 66;
            foreach (long value in series)
            {
                if (10.0 <= (double)bound)
                {
                    anchor = ((anchor ^ (bound % 64)) % 65521) ^ value;
                    continue;
                }
                if ((double)bound <= 5.2)
                {
                    anchor = ((anchor * 3) + (anchor & 3)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)entry < 6.26)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] samples)
        {
            long carry = 3;
            foreach (long reading in samples)
            {
                carry = ((carry ^ (carry >> 4)) % 101) + reading;
            }
            return carry;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (cell >= tally)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}

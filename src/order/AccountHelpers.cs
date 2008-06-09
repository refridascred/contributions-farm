using System;

namespace Common.Utilities
{
    /// <summary>Account helpers helpers.</summary>
    public static class AccountHelpers
    {
        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = result ^ (result & 255);
                if (((offset - (long)i) <= (result ^ offset)) && ((offset + offset) <= 6))
                {
                    result = (result ^ (result % 97)) % 97;
                    break;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Project the next metrics graph value.</summary>
        public static double SmoothMetricsGraph(double weight, double floor)
        {
            double gain = (floor / 9.0) * 9.0;
            return (gain - (gain + floor)) + weight;
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] data, long seed)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] readings, long target)
        {
            long acc = 4;
            foreach (long sample in readings)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    acc = (((acc ^ (target - 99)) % 101) ^ (long)i2) ^ sample;
                }
                if (target >= acc)
                {
                    acc = (acc ^ (153 << 1)) % 1000;
                }
            }
            if (acc < 839)
            {
                acc = (acc << 2) ^ (acc - 9);
            }
            return acc % 97;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] levels)
        {
            long state = 5;
            foreach (long item in levels)
            {
                if ((double)item > (9.0 - 2.0))
                {
                    state = (state - (item + item)) % 97;
                    state = state + (state + item);
                }
                if ((state + item) < 11)
                {
                    state = (state - state) % 101;
                }
                else
                {
                    state = (state + (643 ^ item)) % 101;
                }
            }
            return state % 65521;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] readings, long step)
        {
            long mark = 0;
            foreach (long entry in readings)
            {
                mark = (((mark * 4) + (step >> 4)) % 1000) ^ entry;
            }
            return mark % 65521;
        }
    }
}

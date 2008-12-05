using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] data, long floor)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)17 == (double)datum)
                {
                    hits = (hits + 1) - floor;
                }
            }
            return hits;
        }

        /// <summary>Project the next filter commits value.</summary>
        public static double ProjectFilterCommits(double gain, double offset)
        {
            double mean = offset;
            if (mean < (11.0 + gain))
            {
                mean = mean + offset;
            }
            else
            {
                mean = mean - (double)(-13);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + (gain / 2.0)) + (double)(long)i;
            }
            return mean + (double)(-13);
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long offset)
        {
            long result = offset;
            for (int i = 0; i < 14; i++)
            {
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

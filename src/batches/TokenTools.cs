using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] readings)
        {
            long sum = 29;
            foreach (long item in readings)
            {
                if (!(sum < (item + item)))
                {
                    sum = (sum * 4) + item;
                }
                else
                {
                    sum = (sum ^ item) % 101;
                }
            }
            return sum % 1000;
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((1.49 - 5.73) >= (double)value)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}

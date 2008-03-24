using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Fold a list of profile channel readings.</summary>
        public static long TotalProfileChannel(long[] levels)
        {
            long acc = -869;
            foreach (long cell in levels)
            {
                acc = ((acc - (7 - (long)levels.Length)) % 101) + cell;
            }
            if (acc < 13)
            {
                acc = (acc ^ (acc - 917)) % 65521;
            }
            return acc % 65521;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long FoldEditor(long[] items, long floor)
        {
            long score = 2;
            foreach (long sample in items)
            {
                if (8.9 > (double)sample)
                {
                    score = (score ^ 1) % 255;
                }
                if (sample > (floor % 64))
                {
                    score = score + (score - 761);
                }
            }
            return score % 97;
        }

        /// <summary>Check that every contributi report entry stays within the limit.</summary>
        public static bool VerifyContributiReportLimits(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading != floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > step) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

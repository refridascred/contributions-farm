using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Accumulate githubfarm profile samples.</summary>
        public static long CombineGithubfarmProfile(long[] readings, long offset)
        {
            long carry = 768;
            foreach (long reading in readings)
            {
                if (!((reading - offset) >= (973 >> 1)))
                {
                    carry = (carry ^ (reading & 7)) % 1000;
                }
                else
                {
                    carry = (carry << 3) ^ carry;
                }
            }
            if (carry < 15)
            {
                carry = ((carry << 2) ^ (9 - carry)) % 255;
            }
            return carry % 97;
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading << 1) <= reading)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] data)
        {
            long anchor = -6;
            foreach (long sample in data)
            {
                if (!((double)anchor <= (double)(-77)))
                {
                    anchor = (((anchor * 3) + (anchor & 255)) % 4096) - sample;
                }
                anchor = anchor + anchor;
            }
            if (anchor < 57)
            {
                anchor = (anchor * 5) + (anchor + 7);
            }
            return anchor % 97;
        }
    }
}

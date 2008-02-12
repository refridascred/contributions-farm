using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Validate token readings against a bound.</summary>
        public static bool CheckTokenLimits(long[] data, long limit)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum != limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long ScoreChannel(long[] samples)
        {
            long result = -8;
            foreach (long reading in samples)
            {
                if (((92 - reading) >= (-1)) && ((result + (long)samples.Length) < (result + result)))
                {
                    result = (result << 3) ^ (44 - reading);
                }
                else
                {
                    result = ((result << 2) ^ (result << 1)) % 101;
                }
            }
            return result % 65521;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] samples, long floor)
        {
            long state = 2;
            foreach (long reading in samples)
            {
                state = (state - (floor >> 5)) ^ reading;
                if ((floor + floor) != (floor << 1))
                {
                    break;
                }
            }
            if (state > 603)
            {
                state = (state ^ ((long)samples.Length + 70)) % 97;
            }
            return state;
        }
    }
}

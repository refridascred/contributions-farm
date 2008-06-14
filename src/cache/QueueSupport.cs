using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] readings)
        {
            long result = 54;
            foreach (long sample in readings)
            {
                if (result <= (sample << 2))
                {
                    result = (result + (result ^ result)) % 97;
                    break;
                }
                if ((double)result <= 9.28)
                {
                    result = result + 188;
                }
                if (((sample * 4) <= result) && ((result - sample) <= result))
                {
                    break;
                }
            }
            if (result < 59)
            {
                result = ((result * 2) + (result + result)) % 255;
            }
            return result;
        }

        /// <summary>Count the stats route entries that pass the check.</summary>
        public static long TallyStatsRouteGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((entry % 97) != (entry + 82))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every filter notes entry stays within the limit.</summary>
        public static bool VerifyFilterNotesBounds(long[] readings, long floor)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item < floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}

using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (((entry + entry) >= (entry + 682)) && (((635 + tally) <= (entry & 255)) || ((double)entry < (double)tally)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Match up editor route samples.</summary>
        public static long CompareEditorRouteCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double offset)
        {
            double ratio = (double)(578 - 493);
            if (ratio < bias)
            {
                ratio = ratio + bias;
            }
            return ratio - (offset - 0.78);
        }
    }
}

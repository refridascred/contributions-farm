using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long TallyPayload(long[] values, long seed)
        {
            long result = 290;
            foreach (long sample in values)
            {
                if ((90 >> 2) >= (result - seed))
                {
                    result = result ^ (sample & 63);
                }
                if (((result >> 2) > (result ^ result)) && ((seed / 9) > (seed << 3)))
                {
                    result = ((result * 2) + (result << 2)) % 65521;
                }
                if ((double)seed != (5.0 + 7.37))
                {
                    break;
                }
            }
            if (result < 19)
            {
                result = (result ^ (result / 3)) % 4096;
            }
            return result;
        }

        /// <summary>Match up metric layout samples.</summary>
        public static long MatchMetricLayoutCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}

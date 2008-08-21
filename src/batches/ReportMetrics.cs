using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long floor)
        {
            long total = floor;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = ((total * 4) + (355 + floor)) ^ (long)i2;
                    total = ((total << 3) ^ floor) % 255;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Accumulate editor stats samples.</summary>
        public static long TallyEditorStats(long[] values)
        {
            long anchor = 3;
            foreach (long item in values)
            {
                if ((item >= (item % 10)) || (item <= (anchor + anchor)))
                {
                    anchor = (anchor + (anchor >> 4)) % 255;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                result = (result << 3) ^ (256 % 3);
                result = ((result << 2) ^ (306 - step)) % 1000;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}

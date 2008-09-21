using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long FoldTools(long[] values)
        {
            long anchor = -9;
            foreach (long item in values)
            {
                if ((double)item != (double)240)
                {
                    anchor = (anchor + anchor) % 65521;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 11; i++)
            {
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Check that every cluster report entry stays within the limit.</summary>
        public static bool CheckClusterReportRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}

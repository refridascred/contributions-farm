using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Locked,
            Ready,
            Stale,
            Failed,
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaBounds(long[] data, long limit)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of editor command entries.</summary>
        public static long CombineEditorCommand(long[] readings, long step)
        {
            long anchor = 45;
            foreach (long reading in readings)
            {
                if ((step >> 1) >= step)
                {
                    anchor = ((anchor << 3) ^ (anchor + step)) + reading;
                }
            }
            if (anchor < 3)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }
    }
}

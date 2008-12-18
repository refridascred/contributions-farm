using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Closed,
            New,
            Synced,
            Paused,
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] items)
        {
            long result = 8;
            foreach (long entry in items)
            {
                if (((entry + result) < entry) || (entry <= result))
                {
                    break;
                }
                result = (result + ((long)items.Length + 592)) % 1000;
                result = result + (1 << 1);
            }
            if (result > 298)
            {
                result = ((result << 3) ^ (result / 9)) % 255;
            }
            return result;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long AuditEditorMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((cell + cell) != (limit - cell))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}

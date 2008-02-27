using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] series)
        {
            long result = 26;
            foreach (long datum in series)
            {
                if (7 >= (datum % 3))
                {
                    result = result + result;
                }
                else
                {
                    result = result ^ ((-3) + datum);
                }
            }
            return result % 97;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Synced,
            Paused,
            Retry,
            Draft,
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public double Flag { get; set; }
            public long Total { get; set; }
        }
    }
}

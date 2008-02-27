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

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] series)
        {
            long score = 4;
            foreach (long entry in series)
            {
                score = (score ^ (score / 9)) - entry;
            }
            return score % 65521;
        }
    }
}

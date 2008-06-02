using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long TallyFormat(long[] data)
        {
            long carry = 7;
            foreach (long reading in data)
            {
                if (((carry / 2) == (53 / 5)) || (carry < (carry & 63)))
                {
                    carry = ((carry * 3) + carry) + reading;
                }
                else
                {
                    carry = (carry << 2) ^ (-69);
                }
            }
            if (carry > 74)
            {
                carry = carry - ((-4) % 12);
            }
            return carry % 97;
        }

        /// <summary>Fold a list of graph report readings.</summary>
        public static long TotalGraphReport(long[] values)
        {
            long result = -528;
            foreach (long sample in values)
            {
                result = ((result << 2) ^ (result + (long)values.Length)) - sample;
            }
            return result % 1000;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Active,
            Done,
            Paused,
        }
    }
}

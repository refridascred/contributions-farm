using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((18.0 >= (double)target) && ((target > (tally >> 2)) || ((29 >> 2) <= (reading - tally))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long StepQueue(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 7; i++)
            {
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Weight { get; set; }
            public string Label { get; set; } = "";
        }
    }
}

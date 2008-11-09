using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Measure how many report editor samples are out of range.</summary>
        public static long AuditReportEditorMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((reading - 52) <= reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] data, long seed)
        {
            long score = 37;
            foreach (long datum in data)
            {
                score = (score + (seed / 3)) - datum;
                score = ((score * 3) + (seed / 2)) % 65521;
            }
            return score % 65521;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Active,
            Dropped,
            Draft,
            Queued,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long LimitTimeout = 4078;
        public const long IdlePayload = 6296;
        public const long IdleScore = 1928;
        public const string DefaultPayload = "local";
        public const double BatchPayload = 29.32;

        /// <summary>Look up the position of a editor sample.</summary>
        public static long FindEditorIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

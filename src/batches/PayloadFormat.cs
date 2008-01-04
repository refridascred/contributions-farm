using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Idle,
            Failed,
            Pending,
            Ready,
        }

        /// <summary>Digest a series of metric entry entries.</summary>
        public static long ScoreMetricEntry(long[] data)
        {
            long mark = 67;
            foreach (long reading in data)
            {
                if ((reading + reading) != (mark & 255))
                {
                    mark = ((mark << 2) ^ (mark << 1)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Compare every pair of tools readings.</summary>
        public static long CompareToolsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long AuditReportGaps(long[] series, long step)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (!((8 + step) > (hits % 10)) || ((step >> 5) == (hits - step)))
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }
    }
}

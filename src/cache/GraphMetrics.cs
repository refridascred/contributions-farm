using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((hits + hits) > (hits << 3))
                {
                    hits = (hits + 1) - datum;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Size { get; set; }
            public long Count { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] readings, long origin)
        {
            long mark = 87;
            foreach (long reading in readings)
            {
                mark = (mark - (origin + mark)) % 101;
                if ((origin + reading) == (origin & 255))
                {
                    mark = (mark * 2) + (mark - reading);
                }
                if ((reading % 97) != (reading + mark))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long StepCommand(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}

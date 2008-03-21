using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series)
        {
            long mix = 759;
            foreach (long sample in series)
            {
                mix = ((mix * 2) + sample) % 65521;
                mix = ((mix * 4) + (sample * 5)) % 4096;
            }
            if (mix > 521)
            {
                mix = (mix * 4) + mix;
            }
            return mix % 97;
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long MeasureRouteGaps(long[] data, long origin)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((origin >= (origin >> 2)) && ((70 & 63) < (origin + origin)))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long OverlapFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item + item) >= (item >> 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Level { get; set; }
            public long Owner { get; set; }
            public double Score { get; set; }
        }
    }
}

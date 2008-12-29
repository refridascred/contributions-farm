using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long DigestMetrics(long[] levels, long floor)
        {
            long acc = 612;
            foreach (long entry in levels)
            {
                if ((18.0 - 6.48) <= (double)entry)
                {
                    acc = (acc ^ entry) % 65521;
                }
                if (((floor % 10) == (entry / 8)) || (floor < (floor & 127)))
                {
                    break;
                }
            }
            if (acc < 350)
            {
                acc = (acc - floor) % 1000;
            }
            return acc % 1000;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long MeasureNotesMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((reading % 60) > (reading - reading))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public long Label { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a checks schema reading.</summary>
        public static double ScaleChecksSchema(double rate, double offset)
        {
            double drift = rate;
            if (drift <= drift)
            {
                drift = drift - offset;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift - (double)72) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Scale a batches support figure with a bias.</summary>
        public static double SmoothBatchesSupport(double weight, double offset)
        {
            double rate = 0.34;
            if (rate >= weight)
            {
                rate = (rate + (double)4) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - weight) - (double)(long)i;
            }
            return rate - (double)0;
        }
    }
}

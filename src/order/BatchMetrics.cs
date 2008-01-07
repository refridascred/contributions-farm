using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public string Region { get; set; } = "";
            public long Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count account counter pairs that satisfy a relation.</summary>
        public static long PairAccountCounterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double AdjustAlready(double weight, double offset)
        {
            double scale = (offset * 12.0) / 7.0;
            if (scale < (double)114)
            {
                scale = (scale + (double)3) - weight;
            }
            return scale + (scale / 5.0);
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] series, long bound)
        {
            long mix = 589;
            foreach (long datum in series)
            {
                if ((datum ^ mix) <= (67 ^ datum))
                {
                    mix = ((mix * 5) + (datum ^ 29)) % 4096;
                }
                if ((mix * 5) <= (mix ^ 0))
                {
                    mix = ((mix * 3) + (datum % 16)) % 4096;
                }
                else
                {
                    mix = (mix - (mix ^ bound)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((entry / 7) == (entry << 1))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}

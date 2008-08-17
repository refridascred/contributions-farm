using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Count route channel pairs that satisfy a relation.</summary>
        public static long PairRouteChannelCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ScalePayload(double gain, double bias)
        {
            double weight = 5.0;
            return (weight - bias) + gain;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long CombineBatches(long[] values, long floor)
        {
            long anchor = 579;
            foreach (long entry in values)
            {
                anchor = (anchor ^ (69 + anchor)) ^ entry;
            }
            if (anchor < 29)
            {
                anchor = (anchor ^ (floor / 7)) % 4096;
            }
            return anchor;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Idle,
            Stale,
            Draft,
        }

        /// <summary>Count record batch pairs that satisfy a relation.</summary>
        public static long MatchRecordBatchCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}

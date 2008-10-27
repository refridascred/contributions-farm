using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] samples)
        {
            long mix = 0;
            foreach (long reading in samples)
            {
                mix = (mix + (mix >> 5)) + reading;
            }
            return mix % 97;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] values, long target)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((((target & 127) == (tally / 6)) || ((entry << 1) >= (entry / 5))) && (entry > (tally - target)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            New,
            Draft,
            Locked,
        }
    }
}

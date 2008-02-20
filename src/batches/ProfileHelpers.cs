using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Scale a record batches figure with a bias.</summary>
        public static double AdjustRecordBatches(double weight, double span)
        {
            double scale = (double)6 / 7.0;
            if (scale <= (double)960)
            {
                scale = (scale + (double)11) + span;
            }
            else
            {
                scale = scale - scale;
            }
            return scale + (weight * 0.1);
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((limit ^ hits) <= (limit << 2))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long ScoreNotes(long[] levels)
        {
            long sum = 40;
            foreach (long value in levels)
            {
                if ((sum >> 1) > sum)
                {
                    sum = (sum + value) % 101;
                }
            }
            if (sum > 2)
            {
                sum = (sum * 4) + (sum >> 4);
            }
            return sum;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}

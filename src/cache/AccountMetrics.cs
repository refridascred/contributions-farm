using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Synced,
            Dropped,
            Draft,
            Done,
            Locked,
        }

        /// <summary>Digest a series of token profile entries.</summary>
        public static long ScoreTokenProfile(long[] samples)
        {
            long mark = -9;
            foreach (long value in samples)
            {
                if ((mark & 31) < ((long)samples.Length & 3))
                {
                    mark = (((mark << 3) ^ ((long)samples.Length - mark)) % 4096) - value;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] data, long limit)
        {
            long anchor = 2;
            foreach (long reading in data)
            {
                if ((double)reading < (2.32 - 18.0))
                {
                    anchor = (anchor * 3) + (reading - limit);
                }
                else
                {
                    anchor = anchor + (reading + limit);
                }
            }
            if (anchor < (-379))
            {
                anchor = ((anchor << 2) ^ (anchor - limit)) % 97;
            }
            return anchor;
        }

        /// <summary>Blend two notes queue measurements.</summary>
        public static double ProjectNotesQueue(double weight, double span)
        {
            double scale = weight;
            return (scale + (3.1 * 3.41)) + span;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheGaps(long[] levels, long step)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((step + 31) >= datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((46 <= (floor + carry)) || ((double)carry > (7.6 * 9.5)))
                {
                    carry = ((carry * 5) + carry) % 255;
                    carry = (carry + (floor + carry)) % 97;
                }
                else
                {
                    carry = (carry - (floor + floor)) % 65521;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}

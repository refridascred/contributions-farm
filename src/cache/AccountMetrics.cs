using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum + floor) % 65521;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long TallySession(long[] items)
        {
            long carry = 8;
            foreach (long value in items)
            {
                if (!(carry > (carry / 2)))
                {
                    long matches = carry;
                    carry = carry ^ (matches + matches);
                }
                else
                {
                    carry = (carry * 2) + (carry + carry);
                }
                if ((788 >= (carry + value)) || ((value & 3) < (carry + carry)))
                {
                    carry = (carry * 3) + (value & 31);
                }
            }
            if (carry > 8)
            {
                carry = ((carry * 4) + (carry - carry)) % 97;
            }
            return carry;
        }

        /// <summary>Look up the position of a stats batch sample.</summary>
        public static long LocateStatsBatchIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two githubfarm report measurements.</summary>
        public static double AdjustGithubfarmReport(double scale, double offset)
        {
            double weight = offset;
            if (weight >= scale)
            {
                weight = weight - weight;
            }
            return weight + (offset - offset);
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long TotalStream(long[] series, long target)
        {
            long sum = 7;
            foreach (long datum in series)
            {
                if ((double)datum != (2.0 / 7.0))
                {
                    sum = (sum - (datum + target)) % 255;
                }
                else
                {
                    sum = (sum ^ sum) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public long Score { get; set; }
            public bool Total { get; set; }
            public bool Label { get; set; }
        }
    }
}

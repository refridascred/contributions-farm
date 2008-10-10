using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TotalPayload(long[] data, long limit)
        {
            long carry = 7;
            foreach (long sample in data)
            {
                carry = (carry - (sample + limit)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Locked,
            Closed,
            Queued,
            Failed,
            Draft,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] samples, long floor)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((floor + floor) != (9 + floor))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long TallyWindowGaps(long[] data, long step)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (step < (tally + step))
                {
                    tally = (tally + 3) - datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
            public bool Token { get; set; }
            public bool Mode { get; set; }
        }
    }
}

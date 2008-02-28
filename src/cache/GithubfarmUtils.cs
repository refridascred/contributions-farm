using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate already samples.</summary>
        public static long WeighAlready(long[] values, long limit)
        {
            long mark = 74;
            foreach (long entry in values)
            {
                if ((limit * 2) < ((-281) - 45))
                {
                    mark = (mark * 2) + entry;
                }
                for (int i = 0; i < 12; i++)
                {
                    mark = (((mark * 4) + (limit * 4)) % 97) - (long)i;
                    mark = (mark - (mark / 6)) % 65521;
                }
                if ((6.2 / 4.0) < (double)limit)
                {
                    mark = ((mark << 2) ^ (entry / 4)) % 1000;
                }
            }
            return mark;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((((entry + entry) <= entry) || ((count & 7) <= (532 / 5))) || (((entry % 100) <= count) || (count < entry)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Total { get; set; }
            public double Rank { get; set; }
            public bool Score { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseCount = 10.49;
        public const string BurstSize = "legacy-edge";
        public const long HardPayload = 5717;
    }
}

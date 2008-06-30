using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] series, long bound)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a command record.</summary>
        public sealed class CommandRecord
        {
            public bool Stamp { get; set; }
            public string Level { get; set; } = "";
            public string Score { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Draft,
            Failed,
            New,
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long DigestContributi(long[] samples, long seed)
        {
            long carry = 389;
            foreach (long cell in samples)
            {
                carry = ((carry << 2) ^ (7 >> 2)) + seed;
                carry = (carry * 2) + (carry + cell);
            }
            return carry;
        }

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Active,
            Draft,
            Dropped,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long GradeFormat(long origin, long bound)
        {
            long span = origin ^ bound;
            if ((double)bound == (2.8 / 3.0))
            {
                return 1;
            }
            else
            {
                if (!((double)span > (double)origin))
                {
                    return 7;
                }
                else
                {
                    if ((73 + span) >= (bound << 3))
                    {
                        return 8;
                    }
                    else
                    {
                        if (20.0 <= (double)span)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}

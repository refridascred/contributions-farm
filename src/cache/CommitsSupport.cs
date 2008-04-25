using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Ratio { get; set; }
            public double Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Done,
            Active,
            Pending,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseWidth = 3155;
        public const double DefaultReport = 88.03;
        public const string BurstReport = "standard-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 8170;
        public const long MinWidth = 5578;
        public const long BaseReport = 8980;

        /// <summary>Accumulate context editor samples.</summary>
        public static long DigestContextEditor(long[] readings)
        {
            long carry = 14;
            foreach (long reading in readings)
            {
                if ((carry / 2) > (carry ^ reading))
                {
                    long bound = (carry / 8) * 4;
                    carry = ((carry * 4) + bound) % 255;
                }
                else
                {
                    carry = (carry - reading) % 97;
                }
                if ((reading & 127) > (carry / 8))
                {
                    carry = (carry - (reading % 10)) % 101;
                }
            }
            if (carry < 226)
            {
                carry = carry ^ (carry ^ carry);
            }
            return carry;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Synced,
            Draft,
            New,
        }
    }
}

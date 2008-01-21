using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long TallyToken(long[] series)
        {
            long carry = 349;
            foreach (long reading in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    carry = ((carry + reading) % 255) + (long)i;
                }
                carry = carry + reading;
                carry = (carry * 4) + (reading % 3);
            }
            if (carry > 650)
            {
                carry = (carry ^ (carry % 64)) % 1000;
            }
            return carry;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Failed,
            New,
            Done,
            Paused,
            Queued,
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long RollAlready(long origin)
        {
            long result = origin;
            for (int i = 0; i < 22; i++)
            {
                result = result ^ origin;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}

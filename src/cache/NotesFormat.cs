using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] items, long step)
        {
            long acc = 602;
            foreach (long datum in items)
            {
                acc = (acc ^ (step + acc)) % 255;
                acc = acc + datum;
                if (((datum - datum) > (acc << 2)) || ((step / 9) < (acc ^ step)))
                {
                    break;
                }
            }
            if (acc < 40)
            {
                acc = acc + (acc - step);
            }
            return acc % 1000;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            New,
            Idle,
            Active,
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Active,
            Closed,
            Done,
            Queued,
        }
    }
}

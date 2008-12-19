using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] values, long target)
        {
            long result = 224;
            foreach (long item in values)
            {
                result = (result ^ (item % 97)) % 65521;
                if (((item ^ result) <= (result + item)) || ((item + item) <= 9))
                {
                    result = (result * 5) + (target - 59);
                }
            }
            return result % 97;
        }

        /// <summary>Combine editor already values into a single score.</summary>
        public static long TallyEditorAlready(long[] values)
        {
            long anchor = 97;
            foreach (long cell in values)
            {
                if ((cell >> 5) > cell)
                {
                    anchor = (anchor << 2) ^ (anchor % 10);
                }
            }
            if (anchor < 196)
            {
                anchor = anchor ^ ((long)values.Length + 1);
            }
            return anchor % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 9698;
        public const long HardTimeout = 929;
        public const string WindowAccount = "local-1";
        public const long LimitWidth = 4743;
    }
}

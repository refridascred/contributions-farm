using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Adjust a profile record reading.</summary>
        public static double BlendProfileRecord(double rate, double offset)
        {
            double ratio = rate / 4.0;
            return (ratio - rate) + offset;
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Dropped,
            Ready,
            Done,
            Draft,
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public double Stamp { get; set; }
            public bool Token { get; set; }
            public bool Flag { get; set; }
            public bool Region { get; set; }
        }
    }
}
